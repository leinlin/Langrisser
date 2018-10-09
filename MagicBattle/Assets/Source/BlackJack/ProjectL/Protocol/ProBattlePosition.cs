using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000647 RID: 1607
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBattlePosition")]
	[Serializable]
	public class ProBattlePosition : IExtensible
	{
		// Token: 0x060057DB RID: 22491 RVA: 0x001996B4 File Offset: 0x001978B4
		public ProBattlePosition()
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

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x060057DC RID: 22492 RVA: 0x0019971C File Offset: 0x0019791C
		// (set) Token: 0x060057DD RID: 22493 RVA: 0x00199724 File Offset: 0x00197924
		[ProtoMember(1, IsRequired = true, Name = "X", DataFormat = DataFormat.TwosComplement)]
		public int X
		{
			get
			{
				return this._X;
			}
			set
			{
				this._X = value;
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x060057DE RID: 22494 RVA: 0x00199730 File Offset: 0x00197930
		// (set) Token: 0x060057DF RID: 22495 RVA: 0x00199738 File Offset: 0x00197938
		[ProtoMember(2, IsRequired = true, Name = "Y", DataFormat = DataFormat.TwosComplement)]
		public int Y
		{
			get
			{
				return this._Y;
			}
			set
			{
				this._Y = value;
			}
		}

		// Token: 0x060057E0 RID: 22496 RVA: 0x00199744 File Offset: 0x00197944
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057E1 RID: 22497 RVA: 0x00199754 File Offset: 0x00197954
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

		// Token: 0x060057E2 RID: 22498 RVA: 0x00199820 File Offset: 0x00197A20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattlePosition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040041F8 RID: 16888
		private int _X;

		// Token: 0x040041F9 RID: 16889
		private int _Y;

		// Token: 0x040041FA RID: 16890
		private IExtension extensionObject;

		// Token: 0x040041FB RID: 16891
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040041FC RID: 16892
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040041FD RID: 16893
		private LuaFunction m_ctor_hotfix;
	}
}
