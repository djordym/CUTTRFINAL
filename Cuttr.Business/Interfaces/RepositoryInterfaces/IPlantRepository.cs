﻿using Cuttr.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuttr.Business.Interfaces.RepositoryInterfaces
{
    public interface IPlantRepository
    {
        Task<Plant> AddPlantAsync(Plant plant);
        Task<Plant> GetPlantByIdAsync(int plantId);
        Task UpdatePlantAsync(Plant plant);
        Task DeletePlantAsync(int plantId);
        Task<IEnumerable<Plant>> GetTradablePlantsByUserIdAsync(int userId);
        Task<IEnumerable<Plant>> GetAllPlantsAsync();
        Task<IEnumerable<Plant>> GetFilteredTradablePlantsAsync(int userId, double originLat, double originLon, int radiusKm, UserPreferences preferences);
    }
}
