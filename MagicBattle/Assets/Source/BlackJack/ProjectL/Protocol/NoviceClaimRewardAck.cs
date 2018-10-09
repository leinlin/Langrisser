using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F9 RID: 2041
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "NoviceClaimRewardAck")]
	[Serializable]
	public class NoviceClaimRewardAck : IExtensible
	{
		// Token: 0x06006788 RID: 26504 RVA: 0x001CCC70 File Offset: 0x001CAE70
		public NoviceClaimRewardAck()
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

		// Token: 0x17001A94 RID: 6804
		// (get) Token: 0x06006789 RID: 26505 RVA: 0x001CCCD8 File Offset: 0x001CAED8
		// (set) Token: 0x0600678A RID: 26506 RVA: 0x001CCCE0 File Offset: 0x001CAEE0
		[ProtoMember(1, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public NoviceClaimRewardReq Req
		{
			get
			{
				return this._Req;
			}
			set
			{
				this._Req = value;
			}
		}

		// Token: 0x17001A95 RID: 6805
		// (get) Token: 0x0600678B RID: 26507 RVA: 0x001CCCEC File Offset: 0x001CAEEC
		// (set) Token: 0x0600678C RID: 26508 RVA: 0x001CCCF4 File Offset: 0x001CAEF4
		[ProtoMember(2, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A96 RID: 6806
		// (get) Token: 0x0600678D RID: 26509 RVA: 0x001CCD00 File Offset: 0x001CAF00
		// (set) Token: 0x0600678E RID: 26510 RVA: 0x001CCD08 File Offset: 0x001CAF08
		[ProtoMember(3, IsRequired = true, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x0600678F RID: 26511 RVA: 0x001CCD14 File Offset: 0x001CAF14
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006790 RID: 26512 RVA: 0x001CCD24 File Offset: 0x001CAF24
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

		// Token: 0x06006791 RID: 26513 RVA: 0x001CCDF0 File Offset: 0x001CAFF0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NoviceClaimRewardAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D8E RID: 19854
		private NoviceClaimRewardReq _Req;

		// Token: 0x04004D8F RID: 19855
		private int _Result;

		// Token: 0x04004D90 RID: 19856
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004D91 RID: 19857
		private IExtension extensionObject;

		// Token: 0x04004D92 RID: 19858
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D93 RID: 19859
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D94 RID: 19860
		private LuaFunction m_ctor_hotfix;
	}
}
