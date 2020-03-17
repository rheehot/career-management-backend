﻿using System.Collections.Generic;

namespace CareerManagement.Entities
{
    /// <summary>
    /// 기술
    /// </summary>
    public class Tech
    {
        /// <summary>
        /// 식별자
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 사용자 식별자
        /// </summary>
        public string UserId { get; set; }
        /// <summary>
        /// 아이콘
        /// </summary>
        public string Icon { get; set; }
        /// <summary>
        /// 기술 항목
        /// </summary>
        public virtual IList<TechItem> Items { get; set; }
        /// <summary>
        /// 사용자
        /// </summary>
        public virtual User User { get; set; }
    }
}