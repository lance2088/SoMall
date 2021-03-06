﻿using System;
using Volo.Abp.Application.Dtos;

namespace TT.Abp.Mall.Application.Products.Dtos
{
    public class ProductCategoryDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Code { get; set; }
    }
}