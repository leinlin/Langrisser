using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007CF RID: 1999
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SoldierSkinWearReq")]
	[Serializable]
	public class SoldierSkinWearReq : IExtensible
	{
		// Token: 0x0600661A RID: 26138 RVA: 0x001C7E04 File Offset: 0x001C6004
		public SoldierSkinWearReq()
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

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x0600661B RID: 26139 RVA: 0x001C7E6C File Offset: 0x001C606C
		// (set) Token: 0x0600661C RID: 26140 RVA: 0x001C7E74 File Offset: 0x001C6074
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x0600661D RID: 26141 RVA: 0x001C7E80 File Offset: 0x001C6080
		// (set) Token: 0x0600661E RID: 26142 RVA: 0x001C7E88 File Offset: 0x001C6088
		[ProtoMember(2, IsRequired = true, Name = "SoldierId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x0600661F RID: 26143 RVA: 0x001C7E94 File Offset: 0x001C6094
		// (set) Token: 0x06006620 RID: 26144 RVA: 0x001C7E9C File Offset: 0x001C609C
		[ProtoMember(3, IsRequired = true, Name = "SoldierSkinId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x06006621 RID: 26145 RVA: 0x001C7EA8 File Offset: 0x001C60A8
		// (set) Token: 0x06006622 RID: 26146 RVA: 0x001C7EB0 File Offset: 0x001C60B0
		[ProtoMember(4, IsRequired = true, Name = "All", DataFormat = DataFormat.Default)]
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

		// Token: 0x06006623 RID: 26147 RVA: 0x001C7EBC File Offset: 0x001C60BC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006624 RID: 26148 RVA: 0x001C7ECC File Offset: 0x001C60CC
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

		// Token: 0x06006625 RID: 26149 RVA: 0x001C7F98 File Offset: 0x001C6198
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SoldierSkinWearReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C7D RID: 19581
		private int _HeroId;

		// Token: 0x04004C7E RID: 19582
		private int _SoldierId;

		// Token: 0x04004C7F RID: 19583
		private int _SoldierSkinId;

		// Token: 0x04004C80 RID: 19584
		private bool _All;

		// Token: 0x04004C81 RID: 19585
		private IExtension extensionObject;

		// Token: 0x04004C82 RID: 19586
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C83 RID: 19587
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C84 RID: 19588
		private LuaFunction m_ctor_hotfix;
	}
}
