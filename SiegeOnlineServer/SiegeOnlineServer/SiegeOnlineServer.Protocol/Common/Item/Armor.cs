﻿//-----------------------------------------------------------------------------------------------------------
// Copyright (C) 2015-2016 SiegeOnline
// 版权所有
//
// 文件名：Armor.cs
//
// 文件功能描述：
//
// 防具属性
//
// 创建标识：taixihuase 20150723
//
// 修改标识：
// 修改描述：
// 
//
// 修改标识：
// 修改描述：
//
//----------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
// ReSharper disable InconsistentNaming

namespace SiegeOnlineServer.Protocol.Common.Item
{
    /// <summary>
    /// 类型：类
    /// 名称：Armor
    /// 作者：taixihuase
    /// 作用：防具类
    /// 编写日期：2015/7/23
    /// </summary>
    [Serializable]
    public class Armor
    {
        public int FixedId { get; protected set; }

        public int AllocatedId { get; protected set; }

        public string Name { get; protected set; }

        #region 防具类型

        [Serializable]
        public enum ArmorType : byte
        {

        }

        public byte Type { get; protected set; }

        #endregion

        [Serializable]
        public enum DefenseType : byte
        {
            Null,
            Defense_Physical,
            Defense_Magic
        }

        public Dictionary<DefenseType, int> DefensePoints; // 防御力

        public Dictionary<int, Dictionary<AttributeCode, int>> ForgingAttributes; // 锻造附加属性

        public Armor(int guid, int allocatedId, string name, ArmorType type)
        {
            FixedId = guid;
            AllocatedId = allocatedId;
            Name = name;
            Type = (byte) type;
            DefensePoints = new Dictionary<DefenseType, int>();
            ForgingAttributes = new Dictionary<int, Dictionary<AttributeCode, int>>();
        }

        public Armor()
        {
            FixedId = 0;
            AllocatedId = 0;
            Name = "";
            Type = 0;
            DefensePoints = new Dictionary<DefenseType, int> {{DefenseType.Null, 0}};
            ForgingAttributes = new Dictionary<int, Dictionary<AttributeCode, int>>
            {
                {-1, new Dictionary<AttributeCode, int> {{AttributeCode.Null, 0}}}
            };
        }
    }
}
