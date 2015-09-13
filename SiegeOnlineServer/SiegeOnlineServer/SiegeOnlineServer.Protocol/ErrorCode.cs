﻿//-----------------------------------------------------------------------------------------------------------
// Copyright (C) 2015-2016 SiegeOnline
// 版权所有
//
// 文件名：ErrorCode.cs
//
// 文件功能描述：
//
// 服务端接收请求后，执行请求操作并反馈操作的执行情况
//
// 创建标识：taixihuase 20150714
//
// 修改标识：
// 修改描述：
// 
//
// 修改标识：
// 修改描述：
//
//----------------------------------------------------------------------------------------------------------

namespace SiegeOnlineServer.Protocol
{
    /// <summary>
    /// 类型：枚举
    /// 名称：ErrorCode
    /// 作者：taixihuase
    /// 作用：错误代码枚举值
    /// 编写日期：2015/7/14
    /// </summary>
    public enum ErrorCode
    {
        Ok = 0, // 成功
        CustomError = 1, // 自定义错误
        InvalidOperation = 2, // 非法操作
        RepeatedOperation = 3, // 重复操作
        EmailNotFound = 4, // 邮箱不存在
        CharacterNotFound = 5, // 角色不存在
    }
}
