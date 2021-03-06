﻿using System.Collections.Generic;

namespace CareerManagement.Entities
{
    /// <summary>
    /// 교육
    /// </summary>
    public class Education
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
        /// 제목
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 상태
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 설명
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 기간
        /// </summary>
        public string Period { get; set; }
        /// <summary>
        /// 링크
        /// </summary>
        public virtual IList<EducationLink> Links { get; set; }
        /// <summary>
        /// 사용자
        /// </summary>
        public virtual User User { get; set; }
    }
}
