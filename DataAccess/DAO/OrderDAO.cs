﻿using BusinessObject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private SalesManagementContext salesManagementContext = new SalesManagementContext();

        public OrderDAO()
        {
        }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Order> GetList() => salesManagementContext.Orders.Include(o => o.OrderDetails).ToList();
        public IEnumerable<Order> GetListByMemberId(int memberId) => salesManagementContext.Orders.Where(o => o.Member.MemberId.Equals(memberId));

        public Order? GetById(int orderId) => salesManagementContext.Orders.SingleOrDefault(o => o.OrderId.Equals(orderId));

        public void Add(Order order)
        {
            if (GetById(order.OrderId) != null)
            {
                throw new Exception("Product ID existed!");
            }
            salesManagementContext.Orders.Add(order);
            salesManagementContext.SaveChanges();
        }

        public void Delete(Order order)
        {
            salesManagementContext.Orders.Remove(order);
            salesManagementContext.SaveChanges();
        }

        public void Update(Order order)
        {
            salesManagementContext.Orders.Update(order);
            salesManagementContext.SaveChanges();
        }

        public IEnumerable<Order> FilterByDate(DateTime startDate, DateTime endate)
            => salesManagementContext.Orders.Where(o => (o.OrderDate.CompareTo(startDate) >= 0 && o.OrderDate.CompareTo(endate) <= 0)).ToList().OrderByDescending(o => o.OrderDate);


    }
}