using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B6 RID: 1974
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "SetProtagonistAck")]
	[Serializable]
	public class SetProtagonistAck : IExtensible
	{
		// Token: 0x0600652F RID: 25903 RVA: 0x001C4EE8 File Offset: 0x001C30E8
		public SetProtagonistAck()
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

		// Token: 0x170019E7 RID: 6631
		// (get) Token: 0x06006530 RID: 25904 RVA: 0x001C4F50 File Offset: 0x001C3150
		// (set) Token: 0x06006531 RID: 25905 RVA: 0x001C4F58 File Offset: 0x001C3158
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

		// Token: 0x170019E8 RID: 6632
		// (get) Token: 0x06006532 RID: 25906 RVA: 0x001C4F64 File Offset: 0x001C3164
		// (set) Token: 0x06006533 RID: 25907 RVA: 0x001C4F6C File Offset: 0x001C316C
		[ProtoMember(2, IsRequired = true, Name = "ProtagonistId", DataFormat = DataFormat.TwosComplement)]
		public int ProtagonistId
		{
			get
			{
				return this._ProtagonistId;
			}
			set
			{
				this._ProtagonistId = value;
			}
		}

		// Token: 0x06006534 RID: 25908 RVA: 0x001C4F78 File Offset: 0x001C3178
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006535 RID: 25909 RVA: 0x001C4F88 File Offset: 0x001C3188
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

		// Token: 0x06006536 RID: 25910 RVA: 0x001C5054 File Offset: 0x001C3254
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SetProtagonistAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BD5 RID: 19413
		private int _Result;

		// Token: 0x04004BD6 RID: 19414
		private int _ProtagonistId;

		// Token: 0x04004BD7 RID: 19415
		private IExtension extensionObject;

		// Token: 0x04004BD8 RID: 19416
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BD9 RID: 19417
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BDA RID: 19418
		private LuaFunction m_ctor_hotfix;
	}
}
