﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XYKernel.OS.Common.Models.Administrative.AlgoRule
{
    /// <summary>
    /// 所有教师每天最大课时数
    /// </summary>
    public class TeachersMaxHoursDailyRule: BaseRule
    {
        /// <summary>
        /// 最大课时数
        /// </summary>
        public int MaxHours { get; set; }

        /// <summary>
        /// 权重
        /// </summary>
        public int Weight { get; set; }
    }
}
