﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using ContosoUniversityFull.Models;

namespace ContosoUniversityFull.Services
{
    public interface ICourseDataService
    {
        Task<Course> GetCourseAsync(int id);

        Task<List<Course>> GetCourseRecommendationsAsync(int courseId, int departmentId);

        void DeleteCourseCache(int id);

        void DeleteCourseRecommendationsCache(int id);
    }
}