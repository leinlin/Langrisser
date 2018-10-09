using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000300 RID: 768
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RealTimePVPConsecutiveWinsMatchmakingInfo")]
	[Serializable]
	public class RealTimePVPConsecutiveWinsMatchmakingInfo : IExtensible
	{
		// Token: 0x06002E21 RID: 11809 RVA: 0x000B8B7C File Offset: 0x000B6D7C
		public RealTimePVPConsecutiveWinsMatchmakingInfo()
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

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x06002E22 RID: 11810 RVA: 0x000B8BE4 File Offset: 0x000B6DE4
		// (set) Token: 0x06002E23 RID: 11811 RVA: 0x000B8BEC File Offset: 0x000B6DEC
		[ProtoMember(1, IsRequired = true, Name = "Count", DataFormat = DataFormat.TwosComplement)]
		public int Count
		{
			get
			{
				return this._Count;
			}
			set
			{
				this._Count = value;
			}
		}

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x06002E24 RID: 11812 RVA: 0x000B8BF8 File Offset: 0x000B6DF8
		// (set) Token: 0x06002E25 RID: 11813 RVA: 0x000B8C00 File Offset: 0x000B6E00
		[ProtoMember(2, IsRequired = true, Name = "DanMin", DataFormat = DataFormat.TwosComplement)]
		public int DanMin
		{
			get
			{
				return this._DanMin;
			}
			set
			{
				this._DanMin = value;
			}
		}

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x06002E26 RID: 11814 RVA: 0x000B8C0C File Offset: 0x000B6E0C
		// (set) Token: 0x06002E27 RID: 11815 RVA: 0x000B8C14 File Offset: 0x000B6E14
		[ProtoMember(3, IsRequired = true, Name = "DanMax", DataFormat = DataFormat.TwosComplement)]
		public int DanMax
		{
			get
			{
				return this._DanMax;
			}
			set
			{
				this._DanMax = value;
			}
		}

		// Token: 0x06002E28 RID: 11816 RVA: 0x000B8C20 File Offset: 0x000B6E20
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E29 RID: 11817 RVA: 0x000B8C30 File Offset: 0x000B6E30
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

		// Token: 0x06002E2A RID: 11818 RVA: 0x000B8CFC File Offset: 0x000B6EFC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPConsecutiveWinsMatchmakingInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002369 RID: 9065
		private int _Count;

		// Token: 0x0400236A RID: 9066
		private int _DanMin;

		// Token: 0x0400236B RID: 9067
		private int _DanMax;

		// Token: 0x0400236C RID: 9068
		private IExtension extensionObject;

		// Token: 0x0400236D RID: 9069
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400236E RID: 9070
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400236F RID: 9071
		private LuaFunction m_ctor_hotfix;
	}
}
