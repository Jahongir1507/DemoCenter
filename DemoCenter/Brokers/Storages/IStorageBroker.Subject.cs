﻿using DemoCenter.Models.Subjects;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCenter.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Subject> InsertSubjectAsync(Subject subject);
        IQueryable<Subject> SelectAllSubjects();
        ValueTask<Subject> SelectSubjectByIdAsync(Guid id);
        ValueTask<Subject> UpdateSubjectAsync(Subject subject);
        ValueTask<Subject> DeleteSubjectAsync(Subject subject);
    }
}
