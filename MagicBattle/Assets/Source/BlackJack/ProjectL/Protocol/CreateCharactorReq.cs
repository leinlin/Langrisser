using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006EF RID: 1775
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "CreateCharactorReq")]
	[Serializable]
	public class CreateCharactorReq : IExtensible
	{
		// Token: 0x06005EDE RID: 24286 RVA: 0x001ADF80 File Offset: 0x001AC180
		public CreateCharactorReq()
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

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x06005EDF RID: 24287 RVA: 0x001ADFE8 File Offset: 0x001AC1E8
		// (set) Token: 0x06005EE0 RID: 24288 RVA: 0x001ADFF0 File Offset: 0x001AC1F0
		[ProtoMember(1, IsRequired = true, Name = "CharactorNickName", DataFormat = DataFormat.Default)]
		public string CharactorNickName
		{
			get
			{
				return this._CharactorNickName;
			}
			set
			{
				this._CharactorNickName = value;
			}
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x001ADFFC File Offset: 0x001AC1FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x001AE00C File Offset: 0x001AC20C
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

		// Token: 0x06005EE3 RID: 24291 RVA: 0x001AE0D8 File Offset: 0x001AC2D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CreateCharactorReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040046FC RID: 18172
		private string _CharactorNickName;

		// Token: 0x040046FD RID: 18173
		private IExtension extensionObject;

		// Token: 0x040046FE RID: 18174
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040046FF RID: 18175
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004700 RID: 18176
		private LuaFunction m_ctor_hotfix;
	}
}
