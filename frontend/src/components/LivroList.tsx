import { useEffect, useState } from 'react'
import type { Livro } from '../types/Livro'
import { getLivros } from '../services/livrosService'

export function LivroList() {
  const [livros, setLivros] = useState<Livro[]>([])
  const [erro, setErro] = useState('')

  useEffect(() => {
    getLivros()
      .then(setLivros)
      .catch(() => setErro('Não foi possível carregar os livros'))
  }, [])

  if (erro) return <p>{erro}</p>

  return (
    <ul>
      {livros.map(livro => (
        <li key={livro.id}>
          <strong>{livro.titulo}</strong> — {livro.autor}
        </li>
      ))}
    </ul>
  )
}
