import axios from 'axios';

export const api = axios.create({
  baseURL: 'http://localhost:8080/api', // URL do seu futuro backend
});

// Interceptor para enviar o token automaticamente
api.interceptors.request.use((config) => {
  const token = localStorage.getItem('@App:token');
  if (token && config.headers) {
    config.headers.Authorization = `Bearer ${token}`;
  }
  return config;
});