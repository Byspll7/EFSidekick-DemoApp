using DemoStore.WebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace DemoStore.WebApi
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .HasKey(x => x.EmployeeId);

            builder
                .Property(x => x.EmployeeId)
                .HasColumnName("EmployeeId")
                .HasPrecision(10, 0);

            builder
                .Property(x => x.EmployeeName)
                .HasColumnName("EmployeeName")
                .IsUnicode(true);

            builder
                .Property(x => x.EmployeeSurname)
                .HasColumnName("EmployeeSurname")
                .IsUnicode(true);

            builder
                .Property(x => x.EmployeeSalary)
                .HasColumnName("EmployeeSalary")
                .HasColumnType("decimal")
                .HasPrecision(18, 0);

            builder
                .Property(x => x.EmployeeDepartment)
                .HasColumnName("EmployeeDepartment")
                .IsUnicode(true);

            builder
                .Property(x => x.EmployeeStatus)
                .HasColumnName("EmployeeStatus");

            builder
                .ToTable("Employee", "dbo");
        }
    }
}
