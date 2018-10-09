using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007BE RID: 1982
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroFetterUnlockAck")]
	[Serializable]
	public class HeroFetterUnlockAck : IExtensible
	{
		// Token: 0x06006572 RID: 25970 RVA: 0x001C5DB0 File Offset: 0x001C3FB0
		public HeroFetterUnlockAck()
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

		// Token: 0x170019F9 RID: 6649
		// (get) Token: 0x06006573 RID: 25971 RVA: 0x001C5E18 File Offset: 0x001C4018
		// (set) Token: 0x06006574 RID: 25972 RVA: 0x001C5E20 File Offset: 0x001C4020
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

		// Token: 0x170019FA RID: 6650
		// (get) Token: 0x06006575 RID: 25973 RVA: 0x001C5E2C File Offset: 0x001C402C
		// (set) Token: 0x06006576 RID: 25974 RVA: 0x001C5E34 File Offset: 0x001C4034
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

		// Token: 0x170019FB RID: 6651
		// (get) Token: 0x06006577 RID: 25975 RVA: 0x001C5E40 File Offset: 0x001C4040
		// (set) Token: 0x06006578 RID: 25976 RVA: 0x001C5E48 File Offset: 0x001C4048
		[ProtoMember(3, IsRequired = true, Name = "FetterId", DataFormat = DataFormat.TwosComplement)]
		public int FetterId
		{
			get
			{
				return this._FetterId;
			}
			set
			{
				this._FetterId = value;
			}
		}

		// Token: 0x170019FC RID: 6652
		// (get) Token: 0x06006579 RID: 25977 RVA: 0x001C5E54 File Offset: 0x001C4054
		// (set) Token: 0x0600657A RID: 25978 RVA: 0x001C5E5C File Offset: 0x001C405C
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x0600657B RID: 25979 RVA: 0x001C5E68 File Offset: 0x001C4068
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600657C RID: 25980 RVA: 0x001C5E78 File Offset: 0x001C4078
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

		// Token: 0x0600657D RID: 25981 RVA: 0x001C5F44 File Offset: 0x001C4144
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroFetterUnlockAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C07 RID: 19463
		private int _Result;

		// Token: 0x04004C08 RID: 19464
		private int _HeroId;

		// Token: 0x04004C09 RID: 19465
		private int _FetterId;

		// Token: 0x04004C0A RID: 19466
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004C0B RID: 19467
		private IExtension extensionObject;

		// Token: 0x04004C0C RID: 19468
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C0D RID: 19469
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C0E RID: 19470
		private LuaFunction m_ctor_hotfix;
	}
}
