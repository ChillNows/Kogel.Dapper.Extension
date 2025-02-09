﻿using Kogel.Dapper.Extension.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kogel.Dapper.Extension.Test.Model
{
    /// <summary>
    /// 版 本 1.0
    /// Copyright (c) 2018 
    /// 创建人：LHS
    /// 日 期：2018年3月8日
    /// 描述：新闻实体类
    /// </summary>
    //[Display(Schema ="dbo")]
    public class News
    {
        /// <summary>
		/// 新闻主键
        /// </summary>
		[Identity]
        public long Id { get; set; }
        /// <summary>
        /// 新闻标签
        /// </summary>
        public string NewsLabel { get; set; }
        /// <summary>
        /// 头部信息
        /// </summary>
        public string Headlines { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NewsFrom { get; set; }

        public string NewsFromUrl { get; set; }
        public int NewsState { get; set; }

        public bool IsRecommend { get; set; }
        public int NewsType { get; set; }
        public string NewsImage { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime SubDate { get; set; }
        public int StickyPosts { get; set; }

    }

}
