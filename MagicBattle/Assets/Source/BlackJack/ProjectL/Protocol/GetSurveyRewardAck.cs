using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000827 RID: 2087
	[ProtoContract(Name = "GetSurveyRewardAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GetSurveyRewardAck : IExtensible
	{
		// Token: 0x06006909 RID: 26889 RVA: 0x001D959C File Offset: 0x001D779C
		public GetSurveyRewardAck()
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

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x0600690A RID: 26890 RVA: 0x001D9604 File Offset: 0x001D7804
		// (set) Token: 0x0600690B RID: 26891 RVA: 0x001D960C File Offset: 0x001D780C
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

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x0600690C RID: 26892 RVA: 0x001D9618 File Offset: 0x001D7818
		// (set) Token: 0x0600690D RID: 26893 RVA: 0x001D9620 File Offset: 0x001D7820
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x0600690E RID: 26894 RVA: 0x001D962C File Offset: 0x001D782C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600690F RID: 26895 RVA: 0x001D963C File Offset: 0x001D783C
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

		// Token: 0x06006910 RID: 26896 RVA: 0x001D9708 File Offset: 0x001D7908
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetSurveyRewardAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050F0 RID: 20720
		private int _Result;

		// Token: 0x040050F1 RID: 20721
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x040050F2 RID: 20722
		private IExtension extensionObject;

		// Token: 0x040050F3 RID: 20723
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050F4 RID: 20724
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050F5 RID: 20725
		private LuaFunction m_ctor_hotfix;
	}
}
