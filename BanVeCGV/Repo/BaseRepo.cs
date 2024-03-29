using BanVeCGV.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;

namespace BanVeCGV.Repo
{
	public abstract class BaseRepo<T> where T : class
	{
		public static QuanlibvCGVContext dbContext;
		public BaseRepo()
		{
			dbContext = new QuanlibvCGVContext();
		}

		public static void initContex()
		{
			if (dbContext == null)
			{
				dbContext = new QuanlibvCGVContext();
			}
		}
		public static IEnumerable<T> GetAll()
		{
			initContex();
			return dbContext.Set<T>().ToList();
		}

		public static T GetModelById(int id)
		{

			initContex();
			return dbContext.Set<T>().Find(id);
		}


		public static T FindById<T>(int id, string propertyName) where T : class
		{
			initContex();

			var dbSet = dbContext.Set<T>();
			var parameter = Expression.Parameter(typeof(T), "x");
			var property = Expression.Property(parameter, propertyName);
			var lambda = Expression.Lambda<Func<T, bool>>(
				Expression.Equal(property, Expression.Constant(id)),
				parameter);

			// Filter entities in the database based on the dynamically built expression
			var filteredEntities = dbSet.Where(lambda);

			// Execute the query locally to retrieve the first matching entity
			return filteredEntities.FirstOrDefault();
		}


		public static bool IsExistData<T>(string propertyName, object value) where T : class
		{
			initContex();

			var dbSet = dbContext.Set<T>();
			var parameter = Expression.Parameter(typeof(T), "x");
			var property = Expression.Property(parameter, propertyName);
			var propertyType = typeof(T).GetProperty(propertyName)?.PropertyType;

			if (propertyType == null)
			{
				throw new ArgumentException($"Property '{propertyName}' not found in type '{typeof(T).Name}'.");
			}

			var constant = Expression.Constant(value, propertyType);
			var equalExpression = Expression.Equal(property, constant);
			var lambda = Expression.Lambda<Func<T, bool>>(equalExpression, parameter);

			return dbSet.Any(lambda);
		}



		public static bool AddNew(T entity)
		{

			initContex();
			try
			{
				dbContext.Set<T>().Add(entity);
				dbContext.SaveChanges();
				return true; // Successfully added
			}
			catch (Exception)
			{
				// Log the exception if needed
				return false; // Failed to add
			}
		}

		public bool IsDeleteById(int id)
		{

			initContex();
			var entity = dbContext.Set<T>().Find(id);
			if (entity != null)
			{
				dbContext.Set<T>().Remove(entity);
				dbContext.SaveChanges();
				return true;
			}
			return false;
		}
	}
}
