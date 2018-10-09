using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200076A RID: 1898
	[ProtoContract(Name = "GuildSearchAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildSearchAck : IExtensible
	{
		// Token: 0x060062BE RID: 25278 RVA: 0x001BC2A8 File Offset: 0x001BA4A8
		public GuildSearchAck()
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

		// Token: 0x1700193E RID: 6462
		// (get) Token: 0x060062BF RID: 25279 RVA: 0x001BC324 File Offset: 0x001BA524
		// (set) Token: 0x060062C0 RID: 25280 RVA: 0x001BC32C File Offset: 0x001BA52C
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

		// Token: 0x1700193F RID: 6463
		// (get) Token: 0x060062C1 RID: 25281 RVA: 0x001BC338 File Offset: 0x001BA538
		// (set) Token: 0x060062C2 RID: 25282 RVA: 0x001BC340 File Offset: 0x001BA540
		[DefaultValue("")]
		[ProtoMember(2, IsRequired = false, Name = "SearchText", DataFormat = DataFormat.Default)]
		public string SearchText
		{
			get
			{
				return this._SearchText;
			}
			set
			{
				this._SearchText = value;
			}
		}

		// Token: 0x17001940 RID: 6464
		// (get) Token: 0x060062C3 RID: 25283 RVA: 0x001BC34C File Offset: 0x001BA54C
		[ProtoMember(3, Name = "GuildList", DataFormat = DataFormat.Default)]
		public List<ProGuildSearchInfo> GuildList
		{
			get
			{
				return this._GuildList;
			}
		}

		// Token: 0x060062C4 RID: 25284 RVA: 0x001BC354 File Offset: 0x001BA554
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062C5 RID: 25285 RVA: 0x001BC364 File Offset: 0x001BA564
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

		// Token: 0x060062C6 RID: 25286 RVA: 0x001BC430 File Offset: 0x001BA630
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildSearchAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049FC RID: 18940
		private int _Result;

		// Token: 0x040049FD RID: 18941
		private string _SearchText = string.Empty;

		// Token: 0x040049FE RID: 18942
		private readonly List<ProGuildSearchInfo> _GuildList = new List<ProGuildSearchInfo>();

		// Token: 0x040049FF RID: 18943
		private IExtension extensionObject;

		// Token: 0x04004A00 RID: 18944
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A01 RID: 18945
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A02 RID: 18946
		private LuaFunction m_ctor_hotfix;
	}
}
