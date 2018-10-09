using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000798 RID: 1944
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroAssistantClaimRewardAck")]
	[Serializable]
	public class HeroAssistantClaimRewardAck : IExtensible
	{
		// Token: 0x06006414 RID: 25620 RVA: 0x001C1600 File Offset: 0x001BF800
		public HeroAssistantClaimRewardAck()
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

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x06006415 RID: 25621 RVA: 0x001C1668 File Offset: 0x001BF868
		// (set) Token: 0x06006416 RID: 25622 RVA: 0x001C1670 File Offset: 0x001BF870
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

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06006417 RID: 25623 RVA: 0x001C167C File Offset: 0x001BF87C
		// (set) Token: 0x06006418 RID: 25624 RVA: 0x001C1684 File Offset: 0x001BF884
		[ProtoMember(2, IsRequired = true, Name = "Changed", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Changed
		{
			get
			{
				return this._Changed;
			}
			set
			{
				this._Changed = value;
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06006419 RID: 25625 RVA: 0x001C1690 File Offset: 0x001BF890
		// (set) Token: 0x0600641A RID: 25626 RVA: 0x001C1698 File Offset: 0x001BF898
		[ProtoMember(3, IsRequired = true, Name = "Req", DataFormat = DataFormat.Default)]
		public HeroAssistantClaimRewardReq Req
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

		// Token: 0x0600641B RID: 25627 RVA: 0x001C16A4 File Offset: 0x001BF8A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600641C RID: 25628 RVA: 0x001C16B4 File Offset: 0x001BF8B4
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

		// Token: 0x0600641D RID: 25629 RVA: 0x001C1780 File Offset: 0x001BF980
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroAssistantClaimRewardAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B06 RID: 19206
		private int _Result;

		// Token: 0x04004B07 RID: 19207
		private ProChangedGoodsNtf _Changed;

		// Token: 0x04004B08 RID: 19208
		private HeroAssistantClaimRewardReq _Req;

		// Token: 0x04004B09 RID: 19209
		private IExtension extensionObject;

		// Token: 0x04004B0A RID: 19210
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004B0B RID: 19211
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004B0C RID: 19212
		private LuaFunction m_ctor_hotfix;
	}
}
