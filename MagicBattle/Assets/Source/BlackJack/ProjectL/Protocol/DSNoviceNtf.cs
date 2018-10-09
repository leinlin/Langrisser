using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000734 RID: 1844
	[ProtoContract(Name = "DSNoviceNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSNoviceNtf : IExtensible
	{
		// Token: 0x06006128 RID: 24872 RVA: 0x001B6090 File Offset: 0x001B4290
		public DSNoviceNtf()
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

		// Token: 0x170018DB RID: 6363
		// (get) Token: 0x06006129 RID: 24873 RVA: 0x001B60F8 File Offset: 0x001B42F8
		// (set) Token: 0x0600612A RID: 24874 RVA: 0x001B6100 File Offset: 0x001B4300
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018DC RID: 6364
		// (get) Token: 0x0600612B RID: 24875 RVA: 0x001B610C File Offset: 0x001B430C
		// (set) Token: 0x0600612C RID: 24876 RVA: 0x001B6114 File Offset: 0x001B4314
		[ProtoMember(2, IsRequired = true, Name = "Novice", DataFormat = DataFormat.Default)]
		public ProNovice Novice
		{
			get
			{
				return this._Novice;
			}
			set
			{
				this._Novice = value;
			}
		}

		// Token: 0x0600612D RID: 24877 RVA: 0x001B6120 File Offset: 0x001B4320
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600612E RID: 24878 RVA: 0x001B6130 File Offset: 0x001B4330
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

		// Token: 0x0600612F RID: 24879 RVA: 0x001B61FC File Offset: 0x001B43FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSNoviceNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048C1 RID: 18625
		private uint _Version;

		// Token: 0x040048C2 RID: 18626
		private ProNovice _Novice;

		// Token: 0x040048C3 RID: 18627
		private IExtension extensionObject;

		// Token: 0x040048C4 RID: 18628
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048C5 RID: 18629
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048C6 RID: 18630
		private LuaFunction m_ctor_hotfix;
	}
}
