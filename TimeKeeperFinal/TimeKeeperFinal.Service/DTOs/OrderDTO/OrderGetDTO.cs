﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TimeKeeperFinal.Service.DTOs.OrderDTO
{
    public class OrderGetDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AddressInformationId { get; set; }
        public int Count { get; set; }
        public double TotalPrice { get; set; }
    }
}
