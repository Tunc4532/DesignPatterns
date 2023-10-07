﻿namespace DesignPattern.CQRS.CQRSPattern.Results
{
    public class GetProductQueryResult
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

    }
}
