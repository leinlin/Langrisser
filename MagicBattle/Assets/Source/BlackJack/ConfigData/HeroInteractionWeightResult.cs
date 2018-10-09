using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200031B RID: 795
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroInteractionWeightResult")]
	[Serializable]
	public class HeroInteractionWeightResult : IExtensible
	{
		// Token: 0x06002F2D RID: 12077 RVA: 0x000BBEE0 File Offset: 0x000BA0E0
		public HeroInteractionWeightResult()
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

		// Token: 0x17000D47 RID: 3399
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x000BBF48 File Offset: 0x000BA148
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x000BBF50 File Offset: 0x000BA150
		[ProtoMember(1, IsRequired = true, Name = "ResultType", DataFormat = DataFormat.TwosComplement)]
		public HeroInteractionResultType ResultType
		{
			get
			{
				return this._ResultType;
			}
			set
			{
				this._ResultType = value;
			}
		}

		// Token: 0x17000D48 RID: 3400
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x000BBF5C File Offset: 0x000BA15C
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x000BBF64 File Offset: 0x000BA164
		[ProtoMember(2, IsRequired = true, Name = "Weight", DataFormat = DataFormat.TwosComplement)]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				this._Weight = value;
			}
		}

		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x000BBF70 File Offset: 0x000BA170
		// (set) Token: 0x06002F33 RID: 12083 RVA: 0x000BBF78 File Offset: 0x000BA178
		[ProtoMember(3, IsRequired = true, Name = "FavourabilityExp", DataFormat = DataFormat.TwosComplement)]
		public int FavourabilityExp
		{
			get
			{
				return this._FavourabilityExp;
			}
			set
			{
				this._FavourabilityExp = value;
			}
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000BBF84 File Offset: 0x000BA184
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000BBF94 File Offset: 0x000BA194
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

		// Token: 0x06002F36 RID: 12086 RVA: 0x000BC060 File Offset: 0x000BA260
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroInteractionWeightResult));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002425 RID: 9253
		private HeroInteractionResultType _ResultType;

		// Token: 0x04002426 RID: 9254
		private int _Weight;

		// Token: 0x04002427 RID: 9255
		private int _FavourabilityExp;

		// Token: 0x04002428 RID: 9256
		private IExtension extensionObject;

		// Token: 0x04002429 RID: 9257
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400242A RID: 9258
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400242B RID: 9259
		private LuaFunction m_ctor_hotfix;
	}
}
