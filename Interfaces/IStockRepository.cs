﻿using LearningApi.DTOs.Stocks;
using LearningApi.Helpers;
using LearningApi.Models;

namespace LearningApi.Interfaces {
    public interface IStockRepository { // defind this inferface for the repository pattern which is about abstracting away data access
        Task<List<Stock>> GetAllAsync(QueryObject query);
        Task<Stock?> GetByIdAsync(int id); // since this will be calling "FirstOrDefault" it can take on a null value
        Task<Stock> CreateAsync(Stock stockModel);
        Task<Stock?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stock?> DeleteAsync(int id);
        // completed this refactor in episode 11

        Task<bool> StockExists(int id); // added in episode 14
    }
}
