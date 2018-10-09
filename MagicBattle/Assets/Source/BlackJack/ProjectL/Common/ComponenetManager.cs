using System;
using System.Collections.Generic;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000440 RID: 1088
	public class ComponenetManager<ComponentType> where ComponentType : class, IComponentBase
	{
		// Token: 0x06003FC2 RID: 16322 RVA: 0x00127CA8 File Offset: 0x00125EA8
		public ComponenetManager(IComponentOwner owner)
		{
			this.m_owner = owner;
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00127CD0 File Offset: 0x00125ED0
		public T Add<T>() where T : class, IComponentBase, new()
		{
			ComponentType componentType = Activator.CreateInstance<T>() as ComponentType;
			string name = componentType.GetName();
			ComponentType componentType2;
			if (this.m_components.TryGetValue(name, out componentType2))
			{
				return (T)((object)null);
			}
			this.m_components.Add(name, componentType);
			this.m_type2Name.Add(typeof(T), name);
			componentType.Owner = this.m_owner;
			componentType.Init();
			return componentType as T;
		}

		// Token: 0x06003FC4 RID: 16324 RVA: 0x00127D70 File Offset: 0x00125F70
		public void Remove<T>() where T : class, IComponentBase
		{
			T component = this.GetComponent<T>();
			if (component != null)
			{
				this.OnRemove(component);
			}
		}

		// Token: 0x06003FC5 RID: 16325 RVA: 0x00127D9C File Offset: 0x00125F9C
		public T GetComponent<T>() where T : class, IComponentBase
		{
			Type typeFromHandle = typeof(T);
			string key;
			ComponentType componentType;
			if (this.m_type2Name.TryGetValue(typeFromHandle, out key) && this.m_components.TryGetValue(key, out componentType))
			{
				return componentType as T;
			}
			return (T)((object)null);
		}

		// Token: 0x06003FC6 RID: 16326 RVA: 0x00127DF4 File Offset: 0x00125FF4
		public ComponentType GetComponent(string componentName)
		{
			ComponentType result;
			if (this.m_components.TryGetValue(componentName, out result))
			{
				return result;
			}
			return (ComponentType)((object)null);
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x00127E1C File Offset: 0x0012601C
		public List<ComponentType> GetAllcomponents()
		{
			List<ComponentType> list = new List<ComponentType>();
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				list.Add(keyValuePair.Value);
			}
			return list;
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x00127E88 File Offset: 0x00126088
		public bool SerializeComponents<T>(T dest)
		{
			bool flag = false;
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				bool flag2 = flag;
				ComponentType value = keyValuePair.Value;
				flag = (flag2 | value.Serialize<T>(dest));
			}
			return flag;
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x00127EFC File Offset: 0x001260FC
		public void DeSerializeComponents<T>(T source)
		{
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				ComponentType value = keyValuePair.Value;
				value.DeSerialize<T>(source);
			}
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x00127F68 File Offset: 0x00126168
		public void PostDeSerializeComponents()
		{
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				ComponentType value = keyValuePair.Value;
				value.PostDeSerialize();
			}
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x00127FD4 File Offset: 0x001261D4
		public void Tick(uint deltaMillisecond)
		{
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				ComponentType value = keyValuePair.Value;
				value.Tick(deltaMillisecond);
			}
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x00128040 File Offset: 0x00126240
		public void PostInitComponents()
		{
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				ComponentType value = keyValuePair.Value;
				value.PostInit();
			}
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x001280AC File Offset: 0x001262AC
		public void RemoveComponents()
		{
			List<ComponentType> list = new List<ComponentType>(this.m_components.Values);
			foreach (ComponentType componentType in list)
			{
				this.OnRemove(componentType);
			}
		}

		// Token: 0x06003FCE RID: 16334 RVA: 0x0012811C File Offset: 0x0012631C
		private void OnRemove(IComponentBase component)
		{
			component.DeInit();
			this.m_components.Remove(component.GetName());
			this.m_type2Name.Remove(component.GetType());
		}

		// Token: 0x04003020 RID: 12320
		private Dictionary<string, ComponentType> m_components = new Dictionary<string, ComponentType>();

		// Token: 0x04003021 RID: 12321
		private Dictionary<Type, string> m_type2Name = new Dictionary<Type, string>();

		// Token: 0x04003022 RID: 12322
		private IComponentOwner m_owner;
	}
}
