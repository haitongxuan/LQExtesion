//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由T4模板自动生成
//	   生成时间 2020-02-05 09:46:35
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失
//     作者：Justable
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Dapper.Contrib.Extensions;

namespace LQExtension.Model
{	
   
   [Table("Sys_Supplier")]
    public partial class Sys_Supplier
    {
		/// <summary>
    /// 
    /// </summary>
		
	[Key]
		
	public int Id { get; set; }
		/// <summary>
    /// 供应商代码
    /// </summary>
		
	public string SupplierCode { get; set; }
		/// <summary>
    /// 供应商名称
    /// </summary>
		
	public string SupplierName { get; set; }
		/// <summary>
    /// 地址
    /// </summary>
		
	public int AddressId { get; set; }
		/// <summary>
    /// 应付余额
    /// </summary>
		
	public decimal Payable { get; set; }
	   
    }
}

