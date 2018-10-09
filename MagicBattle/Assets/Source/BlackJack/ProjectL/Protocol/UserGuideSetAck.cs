using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006FC RID: 1788
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "UserGuideSetAck")]
	[Serializable]
	public class UserGuideSetAck : IExtensible
	{
		// Token: 0x06005F2E RID: 24366 RVA: 0x001AF668 File Offset: 0x001AD868
		public UserGuideSetAck()
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

		// Token: 0x17001839 RID: 6201
		// (get) Token: 0x06005F2F RID: 24367 RVA: 0x001AF6DC File Offset: 0x001AD8DC
		// (set) Token: 0x06005F30 RID: 24368 RVA: 0x001AF6E4 File Offset: 0x001AD8E4
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

		// Token: 0x1700183A RID: 6202
		// (get) Token: 0x06005F31 RID: 24369 RVA: 0x001AF6F0 File Offset: 0x001AD8F0
		[ProtoMember(2, Name = "CompleteStepIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> CompleteStepIds
		{
			get
			{
				return this._CompleteStepIds;
			}
		}

		// Token: 0x06005F32 RID: 24370 RVA: 0x001AF6F8 File Offset: 0x001AD8F8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F33 RID: 24371 RVA: 0x001AF708 File Offset: 0x001AD908
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

		// Token: 0x06005F34 RID: 24372 RVA: 0x001AF7D4 File Offset: 0x001AD9D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UserGuideSetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400473F RID: 18239
		private int _Result;

		// Token: 0x04004740 RID: 18240
		private readonly List<int> _CompleteStepIds = new List<int>();

		// Token: 0x04004741 RID: 18241
		private IExtension extensionObject;

		// Token: 0x04004742 RID: 18242
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004743 RID: 18243
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004744 RID: 18244
		private LuaFunction m_ctor_hotfix;
	}
}
