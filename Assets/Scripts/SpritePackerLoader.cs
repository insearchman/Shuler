using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SpritePackerLoader : MonoBehaviour 
{
	[SerializeField]
	private SpriteAtlas m_atlas;

	[SerializeField]
	private SpriteRenderer m_renderer;

	void Start () 
	{
		m_renderer.sprite = m_atlas.GetSprite ("A7");
	}
}
