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
   
   [Table("Res_Config")]
    public partial class Res_Config
    {
		/// <summary>
    /// 配置主键
    /// </summary>
		
	[Key]
		
	public int Id { get; set; }
		/// <summary>
    /// 配置参数
    /// </summary>
		
	public string ConfigParameter { get; set; }
		/// <summary>
    /// 配置值
    /// </summary>
		
	public string ConfigValue { get; set; }
	   
    }
}
