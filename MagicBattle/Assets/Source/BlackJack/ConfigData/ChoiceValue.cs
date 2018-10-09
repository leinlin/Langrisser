using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002FC RID: 764
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChoiceValue")]
	[Serializable]
	public class ChoiceValue : IExtensible
	{
		// Token: 0x06002DFF RID: 11775 RVA: 0x000B8418 File Offset: 0x000B6618
		public ChoiceValue()
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

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06002E00 RID: 11776 RVA: 0x000B8480 File Offset: 0x000B6680
		// (set) Token: 0x06002E01 RID: 11777 RVA: 0x000B8488 File Offset: 0x000B6688
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x000B8494 File Offset: 0x000B6694
		// (set) Token: 0x06002E03 RID: 11779 RVA: 0x000B849C File Offset: 0x000B669C
		[ProtoMember(2, IsRequired = true, Name = "Value", DataFormat = DataFormat.TwosComplement)]
		public int Value
		{
			get
			{
				return this._Value;
			}
			set
			{
				this._Value = value;
			}
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x000B84A8 File Offset: 0x000B66A8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x000B84B8 File Offset: 0x000B66B8
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

		// Token: 0x06002E06 RID: 11782 RVA: 0x000B8584 File Offset: 0x000B6784
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChoiceValue));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002350 RID: 9040
		private int _Id;

		// Token: 0x04002351 RID: 9041
		private int _Value;

		// Token: 0x04002352 RID: 9042
		private IExtension extensionObject;

		// Token: 0x04002353 RID: 9043
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002354 RID: 9044
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002355 RID: 9045
		private LuaFunction m_ctor_hotfix;
	}
}
