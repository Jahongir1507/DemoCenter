﻿using DemoCenter.Models.Students;
using DemoCenter.Models.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCenter.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Student> Students { get; set; }
        public async ValueTask<Student> InsertStudentAsync(Student student) =>
            await InsertAsync(student);
        public IQueryable<Student> SelectAllStudents() =>
            SelectAll<Student>();
        public async ValueTask<Student> SelectStudentByIdAsync(Guid id) =>
            await SelectAsync<Student>(id);
        public async ValueTask<Student> UpdateStudentAsync(Student student) =>
            await UpdateAsync(student);
        public async ValueTask<Student> DeleteStudentAsync(Student student) =>
            await DeleteAsync(student); 
    }
}
