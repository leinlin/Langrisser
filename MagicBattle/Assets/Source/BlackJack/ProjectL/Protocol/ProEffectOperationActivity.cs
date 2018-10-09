using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000668 RID: 1640
	[ProtoContract(Name = "ProEffectOperationActivity")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProEffectOperationActivity : IExtensible
	{
		// Token: 0x06005987 RID: 22919 RVA: 0x0019DADC File Offset: 0x0019BCDC
		public ProEffectOperationActivity()
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

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06005988 RID: 22920 RVA: 0x0019DB44 File Offset: 0x0019BD44
		// (set) Token: 0x06005989 RID: 22921 RVA: 0x0019DB4C File Offset: 0x0019BD4C
		[ProtoMember(1, IsRequired = true, Name = "BasicInfo", DataFormat = DataFormat.Default)]
		public ProOperationalActivityBasicInfo BasicInfo
		{
			get
			{
				return this._BasicInfo;
			}
			set
			{
				this._BasicInfo = value;
			}
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x0019DB58 File Offset: 0x0019BD58
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x0019DB68 File Offset: 0x0019BD68
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

		// Token: 0x0600598C RID: 22924 RVA: 0x0019DC34 File Offset: 0x0019BE34
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProEffectOperationActivity));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004320 RID: 17184
		private ProOperationalActivityBasicInfo _BasicInfo;

		// Token: 0x04004321 RID: 17185
		private IExtension extensionObject;

		// Token: 0x04004322 RID: 17186
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004323 RID: 17187
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004324 RID: 17188
		private LuaFunction m_ctor_hotfix;
	}
}
