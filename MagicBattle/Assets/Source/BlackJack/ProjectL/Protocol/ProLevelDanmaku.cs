using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200066D RID: 1645
	[ProtoContract(Name = "ProLevelDanmaku")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProLevelDanmaku : IExtensible
	{
		// Token: 0x060059C0 RID: 22976 RVA: 0x0019E4B4 File Offset: 0x0019C6B4
		public ProLevelDanmaku()
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

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x060059C1 RID: 22977 RVA: 0x0019E528 File Offset: 0x0019C728
		[ProtoMember(1, Name = "Turns", DataFormat = DataFormat.Default)]
		public List<ProTurnDanmaku> Turns
		{
			get
			{
				return this._Turns;
			}
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x0019E530 File Offset: 0x0019C730
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x0019E540 File Offset: 0x0019C740
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

		// Token: 0x060059C4 RID: 22980 RVA: 0x0019E60C File Offset: 0x0019C80C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProLevelDanmaku));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004347 RID: 17223
		private readonly List<ProTurnDanmaku> _Turns = new List<ProTurnDanmaku>();

		// Token: 0x04004348 RID: 17224
		private IExtension extensionObject;

		// Token: 0x04004349 RID: 17225
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400434A RID: 17226
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400434B RID: 17227
		private LuaFunction m_ctor_hotfix;
	}
}
