using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002FF RID: 767
	[ProtoContract(Name = "WaitingTimeInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class WaitingTimeInfo : IExtensible
	{
		// Token: 0x06002E17 RID: 11799 RVA: 0x000B8994 File Offset: 0x000B6B94
		public WaitingTimeInfo()
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

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x000B89FC File Offset: 0x000B6BFC
		// (set) Token: 0x06002E19 RID: 11801 RVA: 0x000B8A04 File Offset: 0x000B6C04
		[ProtoMember(1, IsRequired = true, Name = "WaitingTime", DataFormat = DataFormat.TwosComplement)]
		public int WaitingTime
		{
			get
			{
				return this._WaitingTime;
			}
			set
			{
				this._WaitingTime = value;
			}
		}

		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x06002E1A RID: 11802 RVA: 0x000B8A10 File Offset: 0x000B6C10
		// (set) Token: 0x06002E1B RID: 11803 RVA: 0x000B8A18 File Offset: 0x000B6C18
		[ProtoMember(2, IsRequired = true, Name = "Min", DataFormat = DataFormat.TwosComplement)]
		public int Min
		{
			get
			{
				return this._Min;
			}
			set
			{
				this._Min = value;
			}
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000B8A24 File Offset: 0x000B6C24
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x000B8A2C File Offset: 0x000B6C2C
		[ProtoMember(3, IsRequired = true, Name = "Max", DataFormat = DataFormat.TwosComplement)]
		public int Max
		{
			get
			{
				return this._Max;
			}
			set
			{
				this._Max = value;
			}
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x000B8A38 File Offset: 0x000B6C38
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x000B8A48 File Offset: 0x000B6C48
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

		// Token: 0x06002E20 RID: 11808 RVA: 0x000B8B14 File Offset: 0x000B6D14
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(WaitingTimeInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002362 RID: 9058
		private int _WaitingTime;

		// Token: 0x04002363 RID: 9059
		private int _Min;

		// Token: 0x04002364 RID: 9060
		private int _Max;

		// Token: 0x04002365 RID: 9061
		private IExtension extensionObject;

		// Token: 0x04002366 RID: 9062
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002367 RID: 9063
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002368 RID: 9064
		private LuaFunction m_ctor_hotfix;
	}
}
