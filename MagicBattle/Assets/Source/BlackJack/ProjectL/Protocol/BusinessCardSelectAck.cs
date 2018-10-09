using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006D3 RID: 1747
	[ProtoContract(Name = "BusinessCardSelectAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BusinessCardSelectAck : IExtensible
	{
		// Token: 0x06005DDC RID: 24028 RVA: 0x001AAAA0 File Offset: 0x001A8CA0
		public BusinessCardSelectAck()
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

		// Token: 0x170017DE RID: 6110
		// (get) Token: 0x06005DDD RID: 24029 RVA: 0x001AAB08 File Offset: 0x001A8D08
		// (set) Token: 0x06005DDE RID: 24030 RVA: 0x001AAB10 File Offset: 0x001A8D10
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

		// Token: 0x170017DF RID: 6111
		// (get) Token: 0x06005DDF RID: 24031 RVA: 0x001AAB1C File Offset: 0x001A8D1C
		// (set) Token: 0x06005DE0 RID: 24032 RVA: 0x001AAB24 File Offset: 0x001A8D24
		[ProtoMember(2, IsRequired = true, Name = "TargetUserId", DataFormat = DataFormat.Default)]
		public string TargetUserId
		{
			get
			{
				return this._TargetUserId;
			}
			set
			{
				this._TargetUserId = value;
			}
		}

		// Token: 0x170017E0 RID: 6112
		// (get) Token: 0x06005DE1 RID: 24033 RVA: 0x001AAB30 File Offset: 0x001A8D30
		// (set) Token: 0x06005DE2 RID: 24034 RVA: 0x001AAB38 File Offset: 0x001A8D38
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "BusinessCard", DataFormat = DataFormat.Default)]
		public ProBusinessCard BusinessCard
		{
			get
			{
				return this._BusinessCard;
			}
			set
			{
				this._BusinessCard = value;
			}
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x001AAB44 File Offset: 0x001A8D44
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x001AAB54 File Offset: 0x001A8D54
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

		// Token: 0x06005DE5 RID: 24037 RVA: 0x001AAC20 File Offset: 0x001A8E20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BusinessCardSelectAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004640 RID: 17984
		private int _Result;

		// Token: 0x04004641 RID: 17985
		private string _TargetUserId;

		// Token: 0x04004642 RID: 17986
		private ProBusinessCard _BusinessCard;

		// Token: 0x04004643 RID: 17987
		private IExtension extensionObject;

		// Token: 0x04004644 RID: 17988
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004645 RID: 17989
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004646 RID: 17990
		private LuaFunction m_ctor_hotfix;
	}
}
