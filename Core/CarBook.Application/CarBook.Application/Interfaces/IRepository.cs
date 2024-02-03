﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Application.Interfaces
{
	public interface IRepository<T> where T : class
	{

		Task<List<T>> GetAllAsync(int id);
		Task<T> GetByIdAsync(int id);

		Task<T> CreateAsync(T entity);
		Task<T> UpdateAsync(T entity);
		Task<T> RemoveAsync(T entity);

	}
}
