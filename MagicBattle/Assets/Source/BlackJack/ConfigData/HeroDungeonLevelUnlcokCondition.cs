using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000316 RID: 790
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroDungeonLevelUnlcokCondition")]
	[Serializable]
	public class HeroDungeonLevelUnlcokCondition : IExtensible
	{
		// Token: 0x06002EFB RID: 12027 RVA: 0x000BB558 File Offset: 0x000B9758
		public HeroDungeonLevelUnlcokCondition()
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

		// Token: 0x17000D38 RID: 3384
		// (get) Token: 0x06002EFC RID: 12028 RVA: 0x000BB5C0 File Offset: 0x000B97C0
		// (set) Token: 0x06002EFD RID: 12029 RVA: 0x000BB5C8 File Offset: 0x000B97C8
		[ProtoMember(1, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public HeroDungeonLevellUnlockConditionType ConditionType
		{
			get
			{
				return this._ConditionType;
			}
			set
			{
				this._ConditionType = value;
			}
		}

		// Token: 0x17000D39 RID: 3385
		// (get) Token: 0x06002EFE RID: 12030 RVA: 0x000BB5D4 File Offset: 0x000B97D4
		// (set) Token: 0x06002EFF RID: 12031 RVA: 0x000BB5DC File Offset: 0x000B97DC
		[ProtoMember(2, IsRequired = true, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public int Param1
		{
			get
			{
				return this._Param1;
			}
			set
			{
				this._Param1 = value;
			}
		}

		// Token: 0x17000D3A RID: 3386
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x000BB5E8 File Offset: 0x000B97E8
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x000BB5F0 File Offset: 0x000B97F0
		[ProtoMember(3, IsRequired = true, Name = "Param2", DataFormat = DataFormat.TwosComplement)]
		public int Param2
		{
			get
			{
				return this._Param2;
			}
			set
			{
				this._Param2 = value;
			}
		}

		// Token: 0x06002F02 RID: 12034 RVA: 0x000BB5FC File Offset: 0x000B97FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F03 RID: 12035 RVA: 0x000BB60C File Offset: 0x000B980C
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

		// Token: 0x06002F04 RID: 12036 RVA: 0x000BB6D8 File Offset: 0x000B98D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonLevelUnlcokCondition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002402 RID: 9218
		private HeroDungeonLevellUnlockConditionType _ConditionType;

		// Token: 0x04002403 RID: 9219
		private int _Param1;

		// Token: 0x04002404 RID: 9220
		private int _Param2;

		// Token: 0x04002405 RID: 9221
		private IExtension extensionObject;

		// Token: 0x04002406 RID: 9222
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002407 RID: 9223
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002408 RID: 9224
		private LuaFunction m_ctor_hotfix;
	}
}
