using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000750 RID: 1872
	[ProtoContract(Name = "GmCommandAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GmCommandAck : IExtensible
	{
		// Token: 0x06006204 RID: 25092 RVA: 0x001B93D0 File Offset: 0x001B75D0
		public GmCommandAck()
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

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x06006205 RID: 25093 RVA: 0x001B9438 File Offset: 0x001B7638
		// (set) Token: 0x06006206 RID: 25094 RVA: 0x001B9440 File Offset: 0x001B7640
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

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x06006207 RID: 25095 RVA: 0x001B944C File Offset: 0x001B764C
		// (set) Token: 0x06006208 RID: 25096 RVA: 0x001B9454 File Offset: 0x001B7654
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._ntf;
			}
			set
			{
				this._ntf = value;
			}
		}

		// Token: 0x06006209 RID: 25097 RVA: 0x001B9460 File Offset: 0x001B7660
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600620A RID: 25098 RVA: 0x001B9470 File Offset: 0x001B7670
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

		// Token: 0x0600620B RID: 25099 RVA: 0x001B953C File Offset: 0x001B773C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GmCommandAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400496A RID: 18794
		private int _Result;

		// Token: 0x0400496B RID: 18795
		private ProChangedGoodsNtf _ntf;

		// Token: 0x0400496C RID: 18796
		private IExtension extensionObject;

		// Token: 0x0400496D RID: 18797
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400496E RID: 18798
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400496F RID: 18799
		private LuaFunction m_ctor_hotfix;
	}
}
