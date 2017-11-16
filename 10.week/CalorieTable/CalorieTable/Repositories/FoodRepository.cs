using CalorieTable.Entities;
using CalorieTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieTable.Repositories
{
    public class FoodRepository
    {
        FoodContext FoodContext;

        public FoodRepository(FoodContext foodContext)
        {
            this.FoodContext = foodContext;
        }

        public List<Food> GetAllFood()
        {
            return FoodContext.Foods.ToList();
        }

        public void AddFood(Food food)
        {
            FoodContext.Foods.Add(food);
            FoodContext.SaveChanges();
        }

        public Food GetID(long id)
        {
            return FoodContext.Foods.FirstOrDefault(f => f.Id == id);
        }

        public void ChangeAmount(Food food)
        { 
            FoodContext.Foods.Update(food);
            FoodContext.SaveChanges();
        }

        public void UpdateAmount(Food food, long id)
        {
            var foodToUpdate = GetID(id);
            foodToUpdate.Amount = food.Amount;

            FoodContext.Foods.Update(foodToUpdate);
            FoodContext.SaveChanges();
        }

        public void Delete(long id)
        {
            FoodContext.Foods.Remove(GetID(id));
            FoodContext.SaveChanges();
        }

        public void Remove(Food food)
        {
            FoodContext.Remove(food);
            FoodContext.SaveChanges();
        }

        public Food GetFood()
        {
            return FoodContext.Foods.FirstOrDefault();
        }
    }
}
