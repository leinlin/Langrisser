using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006DC RID: 1756
	[ProtoContract(Name = "HeroRandomActionSetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroRandomActionSetAck : IExtensible
	{
		// Token: 0x06005E1E RID: 24094 RVA: 0x001ABAF8 File Offset: 0x001A9CF8
		public HeroRandomActionSetAck()
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

		// Token: 0x170017EE RID: 6126
		// (get) Token: 0x06005E1F RID: 24095 RVA: 0x001ABB60 File Offset: 0x001A9D60
		// (set) Token: 0x06005E20 RID: 24096 RVA: 0x001ABB68 File Offset: 0x001A9D68
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

		// Token: 0x170017EF RID: 6127
		// (get) Token: 0x06005E21 RID: 24097 RVA: 0x001ABB74 File Offset: 0x001A9D74
		// (set) Token: 0x06005E22 RID: 24098 RVA: 0x001ABB7C File Offset: 0x001A9D7C
		[ProtoMember(2, IsRequired = true, Name = "IsActionRandom", DataFormat = DataFormat.Default)]
		public bool IsActionRandom
		{
			get
			{
				return this._IsActionRandom;
			}
			set
			{
				this._IsActionRandom = value;
			}
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x001ABB88 File Offset: 0x001A9D88
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x001ABB98 File Offset: 0x001A9D98
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

		// Token: 0x06005E25 RID: 24101 RVA: 0x001ABC64 File Offset: 0x001A9E64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroRandomActionSetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004674 RID: 18036
		private int _Result;

		// Token: 0x04004675 RID: 18037
		private bool _IsActionRandom;

		// Token: 0x04004676 RID: 18038
		private IExtension extensionObject;

		// Token: 0x04004677 RID: 18039
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004678 RID: 18040
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004679 RID: 18041
		private LuaFunction m_ctor_hotfix;
	}
}
