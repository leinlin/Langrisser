using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B0 RID: 1968
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroComposeAck")]
	[Serializable]
	public class HeroComposeAck : IExtensible
	{
		// Token: 0x060064F3 RID: 25843 RVA: 0x001C4378 File Offset: 0x001C2578
		public HeroComposeAck()
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

		// Token: 0x170019D5 RID: 6613
		// (get) Token: 0x060064F4 RID: 25844 RVA: 0x001C43E0 File Offset: 0x001C25E0
		// (set) Token: 0x060064F5 RID: 25845 RVA: 0x001C43E8 File Offset: 0x001C25E8
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

		// Token: 0x170019D6 RID: 6614
		// (get) Token: 0x060064F6 RID: 25846 RVA: 0x001C43F4 File Offset: 0x001C25F4
		// (set) Token: 0x060064F7 RID: 25847 RVA: 0x001C43FC File Offset: 0x001C25FC
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x060064F8 RID: 25848 RVA: 0x001C4408 File Offset: 0x001C2608
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064F9 RID: 25849 RVA: 0x001C4418 File Offset: 0x001C2618
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

		// Token: 0x060064FA RID: 25850 RVA: 0x001C44E4 File Offset: 0x001C26E4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroComposeAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BAB RID: 19371
		private int _Result;

		// Token: 0x04004BAC RID: 19372
		private int _HeroId;

		// Token: 0x04004BAD RID: 19373
		private IExtension extensionObject;

		// Token: 0x04004BAE RID: 19374
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BAF RID: 19375
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BB0 RID: 19376
		private LuaFunction m_ctor_hotfix;
	}
}
