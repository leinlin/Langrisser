using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005B3 RID: 1459
	[ProtoContract(Name = "ArenaPlayerInfoGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ArenaPlayerInfoGetAck : IExtensible
	{
		// Token: 0x060052BA RID: 21178 RVA: 0x001880C8 File Offset: 0x001862C8
		public ArenaPlayerInfoGetAck()
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

		// Token: 0x17001442 RID: 5186
		// (get) Token: 0x060052BB RID: 21179 RVA: 0x00188130 File Offset: 0x00186330
		// (set) Token: 0x060052BC RID: 21180 RVA: 0x00188138 File Offset: 0x00186338
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

		// Token: 0x17001443 RID: 5187
		// (get) Token: 0x060052BD RID: 21181 RVA: 0x00188144 File Offset: 0x00186344
		// (set) Token: 0x060052BE RID: 21182 RVA: 0x0018814C File Offset: 0x0018634C
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "ArenaPlayerData", DataFormat = DataFormat.Default)]
		public ProArenaPlayerInfo ArenaPlayerData
		{
			get
			{
				return this._ArenaPlayerData;
			}
			set
			{
				this._ArenaPlayerData = value;
			}
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00188158 File Offset: 0x00186358
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x00188168 File Offset: 0x00186368
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

		// Token: 0x060052C1 RID: 21185 RVA: 0x00188234 File Offset: 0x00186434
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaPlayerInfoGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E24 RID: 15908
		private int _Result;

		// Token: 0x04003E25 RID: 15909
		private ProArenaPlayerInfo _ArenaPlayerData;

		// Token: 0x04003E26 RID: 15910
		private IExtension extensionObject;

		// Token: 0x04003E27 RID: 15911
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E28 RID: 15912
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E29 RID: 15913
		private LuaFunction m_ctor_hotfix;
	}
}
