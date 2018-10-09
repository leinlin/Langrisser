using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000760 RID: 1888
	[ProtoContract(Name = "GuildJoinApplyGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildJoinApplyGetAck : IExtensible
	{
		// Token: 0x0600627C RID: 25212 RVA: 0x001BB0CC File Offset: 0x001B92CC
		public GuildJoinApplyGetAck()
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

		// Token: 0x17001930 RID: 6448
		// (get) Token: 0x0600627D RID: 25213 RVA: 0x001BB140 File Offset: 0x001B9340
		// (set) Token: 0x0600627E RID: 25214 RVA: 0x001BB148 File Offset: 0x001B9348
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001931 RID: 6449
		// (get) Token: 0x0600627F RID: 25215 RVA: 0x001BB154 File Offset: 0x001B9354
		[ProtoMember(2, Name = "Players", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> Players
		{
			get
			{
				return this._Players;
			}
		}

		// Token: 0x06006280 RID: 25216 RVA: 0x001BB15C File Offset: 0x001B935C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006281 RID: 25217 RVA: 0x001BB16C File Offset: 0x001B936C
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

		// Token: 0x06006282 RID: 25218 RVA: 0x001BB238 File Offset: 0x001B9438
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinApplyGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049C6 RID: 18886
		private int _Result;

		// Token: 0x040049C7 RID: 18887
		private readonly List<ProUserSummary> _Players = new List<ProUserSummary>();

		// Token: 0x040049C8 RID: 18888
		private IExtension extensionObject;

		// Token: 0x040049C9 RID: 18889
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049CA RID: 18890
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049CB RID: 18891
		private LuaFunction m_ctor_hotfix;
	}
}
