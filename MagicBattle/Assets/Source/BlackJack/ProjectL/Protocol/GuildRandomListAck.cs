using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200076C RID: 1900
	[ProtoContract(Name = "GuildRandomListAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildRandomListAck : IExtensible
	{
		// Token: 0x060062CB RID: 25291 RVA: 0x001BC644 File Offset: 0x001BA844
		public GuildRandomListAck()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001941 RID: 6465
		// (get) Token: 0x060062CC RID: 25292 RVA: 0x001BC6B8 File Offset: 0x001BA8B8
		// (set) Token: 0x060062CD RID: 25293 RVA: 0x001BC6C0 File Offset: 0x001BA8C0
		[DefaultValue(0)]
		[ProtoMember(1, IsRequired = false, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001942 RID: 6466
		// (get) Token: 0x060062CE RID: 25294 RVA: 0x001BC6CC File Offset: 0x001BA8CC
		[ProtoMember(3, Name = "GuildList", DataFormat = DataFormat.Default)]
		public List<ProGuildSearchInfo> GuildList
		{
			get
			{
				return this._GuildList;
			}
		}

		// Token: 0x060062CF RID: 25295 RVA: 0x001BC6D4 File Offset: 0x001BA8D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062D0 RID: 25296 RVA: 0x001BC6E4 File Offset: 0x001BA8E4
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060062D1 RID: 25297 RVA: 0x001BC7B0 File Offset: 0x001BA9B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildRandomListAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A07 RID: 18951
		private int _Result;

		// Token: 0x04004A08 RID: 18952
		private readonly List<ProGuildSearchInfo> _GuildList = new List<ProGuildSearchInfo>();

		// Token: 0x04004A09 RID: 18953
		private IExtension extensionObject;

		// Token: 0x04004A0A RID: 18954
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A0B RID: 18955
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A0C RID: 18956
		private LuaFunction m_ctor_hotfix;
	}
}
