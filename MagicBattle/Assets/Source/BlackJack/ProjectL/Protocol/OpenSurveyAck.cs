using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000825 RID: 2085
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "OpenSurveyAck")]
	[Serializable]
	public class OpenSurveyAck : IExtensible
	{
		// Token: 0x060068FF RID: 26879 RVA: 0x001D9230 File Offset: 0x001D7430
		public OpenSurveyAck()
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

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06006900 RID: 26880 RVA: 0x001D9298 File Offset: 0x001D7498
		// (set) Token: 0x06006901 RID: 26881 RVA: 0x001D92A0 File Offset: 0x001D74A0
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

		// Token: 0x06006902 RID: 26882 RVA: 0x001D92AC File Offset: 0x001D74AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006903 RID: 26883 RVA: 0x001D92BC File Offset: 0x001D74BC
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

		// Token: 0x06006904 RID: 26884 RVA: 0x001D9388 File Offset: 0x001D7588
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OpenSurveyAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040050E7 RID: 20711
		private int _Result;

		// Token: 0x040050E8 RID: 20712
		private IExtension extensionObject;

		// Token: 0x040050E9 RID: 20713
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040050EA RID: 20714
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040050EB RID: 20715
		private LuaFunction m_ctor_hotfix;
	}
}
