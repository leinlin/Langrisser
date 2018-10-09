using System;
using ProtoBuf;
using SLua;

namespace BlackJack.BJFramework.Runtime.Lua
{
	// Token: 0x02000068 RID: 104
	public class LuaProtobufExtensionTypeMemberInfo : IProtobufExtensionTypeMemberInfo
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x0001539C File Offset: 0x0001359C
		public LuaProtobufExtensionTypeMemberInfo(string memberName, LuaTable memberDefine, LuaProtoBufExtensionHandler handler)
		{
			this.m_handler = handler;
			this.m_memberName = memberName;
			this.m_memberDefine = memberDefine;
			this.m_tag = Convert.ToInt32(this.m_memberDefine.RawGet("Tag"));
			this.m_enumValue = Convert.ToInt32(this.m_memberDefine.RawGet("Value"));
			this.m_typeName = this.m_memberDefine.RawGet<string>("TypeName");
			this.m_isExtension = this.m_memberDefine.RawGet<bool>("IsExtension");
			this.m_dataFormat = (DataFormat)Enum.Parse(typeof(DataFormat), this.m_memberDefine.RawGet<string>("DataFormat"), true);
			this.m_isRequire = this.m_memberDefine.RawGet<bool>("IsRequire");
			this.m_isRepeated = this.m_memberDefine.RawGet<bool>("IsRepeated");
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00015480 File Offset: 0x00013680
		public int GetTag()
		{
			return this.m_tag;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00015488 File Offset: 0x00013688
		public IProtobufExtensionTypeInfo GetMemberType()
		{
			return this.m_handler.GetExtTypeInfo(this.m_typeName);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001549C File Offset: 0x0001369C
		public string GetName()
		{
			return this.m_memberName;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x000154A4 File Offset: 0x000136A4
		public bool IsExtension()
		{
			return this.m_isExtension;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x000154AC File Offset: 0x000136AC
		public DataFormat GetDataFormat()
		{
			return this.m_dataFormat;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x000154B4 File Offset: 0x000136B4
		public bool IsRequired()
		{
			return this.m_isRequire;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x000154BC File Offset: 0x000136BC
		public bool IsRepeated()
		{
			return this.m_isRepeated;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x000154C4 File Offset: 0x000136C4
		public object GetEnumValue()
		{
			return this.m_enumValue;
		}

		// Token: 0x04000230 RID: 560
		private LuaProtoBufExtensionHandler m_handler;

		// Token: 0x04000231 RID: 561
		private string m_memberName;

		// Token: 0x04000232 RID: 562
		private LuaTable m_memberDefine;

		// Token: 0x04000233 RID: 563
		private int m_tag;

		// Token: 0x04000234 RID: 564
		private string m_typeName;

		// Token: 0x04000235 RID: 565
		private bool m_isExtension;

		// Token: 0x04000236 RID: 566
		private DataFormat m_dataFormat;

		// Token: 0x04000237 RID: 567
		private bool m_isRequire;

		// Token: 0x04000238 RID: 568
		private bool m_isRepeated;

		// Token: 0x04000239 RID: 569
		private int m_enumValue;
	}
}
