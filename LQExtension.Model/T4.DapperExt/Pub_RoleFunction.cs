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
   
   [Table("Pub_RoleFunction")]
    public partial class Pub_RoleFunction
    {
		/// <summary>
    /// 
    /// </summary>
		
	[Key]
		
	public int Id { get; set; }
		/// <summary>
    /// 角色编号
    /// </summary>
		
	public string RoleCode { get; set; }
		/// <summary>
    /// 权限编号
    /// </summary>
		
	public string FunctionCode { get; set; }
		/// <summary>
    /// 
    /// </summary>
		
	public int RoleId { get; set; }
		public Pub_Role Pub_RoleE { get; set; }
			/// <summary>
    /// 
    /// </summary>
		
	public int FunctionId { get; set; }
		public Pub_Function Pub_FunctionE { get; set; }
			/// <summary>
    /// 最后编辑人
    /// </summary>
		
	public string Lmid { get; set; }
		/// <summary>
    /// 最后编辑时间
    /// </summary>
		
	public DateTime? Lmdt { get; set; }
		/// <summary>
    /// 停用状态 默认0 未停用 1 停用
    /// </summary>
		
	public bool? StopFlag { get; set; }
	   
    }
}

