using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200063E RID: 1598
	[ProtoContract(Name = "CommenterHeroViewAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class CommenterHeroViewAck : IExtensible
	{
		// Token: 0x06005768 RID: 22376 RVA: 0x00198430 File Offset: 0x00196630
		public CommenterHeroViewAck()
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

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x06005769 RID: 22377 RVA: 0x00198498 File Offset: 0x00196698
		// (set) Token: 0x0600576A RID: 22378 RVA: 0x001984A0 File Offset: 0x001966A0
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

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x0600576B RID: 22379 RVA: 0x001984AC File Offset: 0x001966AC
		// (set) Token: 0x0600576C RID: 22380 RVA: 0x001984B4 File Offset: 0x001966B4
		[ProtoMember(2, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x1700159B RID: 5531
		// (get) Token: 0x0600576D RID: 22381 RVA: 0x001984C0 File Offset: 0x001966C0
		// (set) Token: 0x0600576E RID: 22382 RVA: 0x001984C8 File Offset: 0x001966C8
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Hero", DataFormat = DataFormat.Default)]
		public ProHero Hero
		{
			get
			{
				return this._Hero;
			}
			set
			{
				this._Hero = value;
			}
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x001984D4 File Offset: 0x001966D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x001984E4 File Offset: 0x001966E4
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

		// Token: 0x06005771 RID: 22385 RVA: 0x001985B0 File Offset: 0x001967B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CommenterHeroViewAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041A7 RID: 16807
		private int _Result;

		// Token: 0x040041A8 RID: 16808
		private string _UserId;

		// Token: 0x040041A9 RID: 16809
		private ProHero _Hero;

		// Token: 0x040041AA RID: 16810
		private IExtension extensionObject;

		// Token: 0x040041AB RID: 16811
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041AC RID: 16812
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041AD RID: 16813
		private LuaFunction m_ctor_hotfix;
	}
}
