//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2020-01-31 18:28:26
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Justable
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dapper.Contrib.Extensions;

namespace LQExtension.Model
{	
   
   [Table("Sys_Warehouse")]
    public partial class Sys_Warehouse
    {
	/// <summary>
    /// 仓库编码
    /// </summary>
		[ExplicitKey]
		
	public string WarehouseCode { get; set; }
	/// <summary>
    /// 仓库名称
    /// </summary>
		
	public string WarehouseName { get; set; }
	/// <summary>
    /// 仓库种类
    /// </summary>
		
	public string WarehouseTypeSelection { get; set; }
	/// <summary>
    /// 启用
    /// </summary>
		
	public bool Active { get; set; }
	/// <summary>
    /// 仓库类型
    /// </summary>
		
	public string WarehouseCategorySelection { get; set; }
	/// <summary>
    /// 创建人
    /// </summary>
		
	public int CreateUid { get; set; }
	/// <summary>
    /// 最后更新人
    /// </summary>
		
	public int WriteUid { get; set; }
	/// <summary>
    /// 创建时间
    /// </summary>
		
	public DateTime CreateDate { get; set; }
	/// <summary>
    /// 最后更新时间
    /// </summary>
		
	public DateTime WriteDate { get; set; }
	/// <summary>
    /// 详细地址
    /// </summary>
		
	public int AddressId { get; set; }
	   
    }
}

