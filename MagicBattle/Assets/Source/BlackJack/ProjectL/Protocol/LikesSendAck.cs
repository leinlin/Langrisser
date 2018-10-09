using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006DA RID: 1754
	[ProtoContract(Name = "LikesSendAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class LikesSendAck : IExtensible
	{
		// Token: 0x06005E0E RID: 24078 RVA: 0x001AB750 File Offset: 0x001A9950
		public LikesSendAck()
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

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06005E0F RID: 24079 RVA: 0x001AB7B8 File Offset: 0x001A99B8
		// (set) Token: 0x06005E10 RID: 24080 RVA: 0x001AB7C0 File Offset: 0x001A99C0
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

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x001AB7CC File Offset: 0x001A99CC
		// (set) Token: 0x06005E12 RID: 24082 RVA: 0x001AB7D4 File Offset: 0x001A99D4
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

		// Token: 0x170017EC RID: 6124
		// (get) Token: 0x06005E13 RID: 24083 RVA: 0x001AB7E0 File Offset: 0x001A99E0
		// (set) Token: 0x06005E14 RID: 24084 RVA: 0x001AB7E8 File Offset: 0x001A99E8
		[DefaultValue(0)]
		[ProtoMember(3, IsRequired = false, Name = "Likes", DataFormat = DataFormat.TwosComplement)]
		public int Likes
		{
			get
			{
				return this._Likes;
			}
			set
			{
				this._Likes = value;
			}
		}

		// Token: 0x06005E15 RID: 24085 RVA: 0x001AB7F4 File Offset: 0x001A99F4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005E16 RID: 24086 RVA: 0x001AB804 File Offset: 0x001A9A04
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

		// Token: 0x06005E17 RID: 24087 RVA: 0x001AB8D0 File Offset: 0x001A9AD0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(LikesSendAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004668 RID: 18024
		private int _Result;

		// Token: 0x04004669 RID: 18025
		private string _TargetUserId;

		// Token: 0x0400466A RID: 18026
		private int _Likes;

		// Token: 0x0400466B RID: 18027
		private IExtension extensionObject;

		// Token: 0x0400466C RID: 18028
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400466D RID: 18029
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400466E RID: 18030
		private LuaFunction m_ctor_hotfix;
	}
}
