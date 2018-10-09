using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006F0 RID: 1776
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "CreateCharactorAck")]
	[Serializable]
	public class CreateCharactorAck : IExtensible
	{
		// Token: 0x06005EE4 RID: 24292 RVA: 0x001AE140 File Offset: 0x001AC340
		public CreateCharactorAck()
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

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x06005EE5 RID: 24293 RVA: 0x001AE1A8 File Offset: 0x001AC3A8
		// (set) Token: 0x06005EE6 RID: 24294 RVA: 0x001AE1B0 File Offset: 0x001AC3B0
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

		// Token: 0x06005EE7 RID: 24295 RVA: 0x001AE1BC File Offset: 0x001AC3BC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x001AE1CC File Offset: 0x001AC3CC
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

		// Token: 0x06005EE9 RID: 24297 RVA: 0x001AE298 File Offset: 0x001AC498
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CreateCharactorAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004701 RID: 18177
		private int _Result;

		// Token: 0x04004702 RID: 18178
		private IExtension extensionObject;

		// Token: 0x04004703 RID: 18179
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004704 RID: 18180
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004705 RID: 18181
		private LuaFunction m_ctor_hotfix;
	}
}
