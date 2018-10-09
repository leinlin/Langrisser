using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D0 RID: 2000
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SoldierSkinWearAck")]
	[Serializable]
	public class SoldierSkinWearAck : IExtensible
	{
		// Token: 0x06006626 RID: 26150 RVA: 0x001C8000 File Offset: 0x001C6200
		public SoldierSkinWearAck()
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

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x06006627 RID: 26151 RVA: 0x001C8068 File Offset: 0x001C6268
		// (set) Token: 0x06006628 RID: 26152 RVA: 0x001C8070 File Offset: 0x001C6270
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

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x06006629 RID: 26153 RVA: 0x001C807C File Offset: 0x001C627C
		// (set) Token: 0x0600662A RID: 26154 RVA: 0x001C8084 File Offset: 0x001C6284
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

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x0600662B RID: 26155 RVA: 0x001C8090 File Offset: 0x001C6290
		// (set) Token: 0x0600662C RID: 26156 RVA: 0x001C8098 File Offset: 0x001C6298
		[ProtoMember(3, IsRequired = true, Name = "SoldierId", DataFormat = DataFormat.TwosComplement)]
		public int SoldierId
		{
			get
			{
				return this._SoldierId;
			}
			set
			{
				this._SoldierId = value;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x0600662D RID: 26157 RVA: 0x001C80A4 File Offset: 0x001C62A4
		// (set) Token: 0x0600662E RID: 26158 RVA: 0x001C80AC File Offset: 0x001C62AC
		[ProtoMember(4, IsRequired = true, Name = "SoldierSkinId", DataFormat = DataFormat.TwosComplement)]
		public int SoldierSkinId
		{
			get
			{
				return this._SoldierSkinId;
			}
			set
			{
				this._SoldierSkinId = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x0600662F RID: 26159 RVA: 0x001C80B8 File Offset: 0x001C62B8
		// (set) Token: 0x06006630 RID: 26160 RVA: 0x001C80C0 File Offset: 0x001C62C0
		[ProtoMember(5, IsRequired = true, Name = "All", DataFormat = DataFormat.Default)]
		public bool All
		{
			get
			{
				return this._All;
			}
			set
			{
				this._All = value;
			}
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x001C80CC File Offset: 0x001C62CC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x001C80DC File Offset: 0x001C62DC
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

		// Token: 0x06006633 RID: 26163 RVA: 0x001C81A8 File Offset: 0x001C63A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SoldierSkinWearAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C85 RID: 19589
		private int _Result;

		// Token: 0x04004C86 RID: 19590
		private int _HeroId;

		// Token: 0x04004C87 RID: 19591
		private int _SoldierId;

		// Token: 0x04004C88 RID: 19592
		private int _SoldierSkinId;

		// Token: 0x04004C89 RID: 19593
		private bool _All;

		// Token: 0x04004C8A RID: 19594
		private IExtension extensionObject;

		// Token: 0x04004C8B RID: 19595
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C8C RID: 19596
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C8D RID: 19597
		private LuaFunction m_ctor_hotfix;
	}
}
