import type { Livro } from '../types/Livro'

const API_URL = 'http://localhost:5062/api/livros'

export async function getLivros(): Promise<Livro[]> {
  const response = await fetch(API_URL)

  if (!response.ok) {
    throw new Error('Erro ao buscar livros')
  }

  return response.json()
}
