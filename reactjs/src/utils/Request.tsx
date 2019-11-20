import axios from 'axios';
import NProgress from 'nprogress';

export default async function request(options) {
  const service = axios.create({});
  //request拦截器
  service.interceptors.request.use(
    config => {
      NProgress.start();
      return config;
    },
    error => {
      Promise.reject(error);
    },
  );
  //响应拦截器
  service.interceptors.response.use(
    response => {
      NProgress.done();
      return response;
    },
    error => Promise.reject(error),
  );
  let response;
  try {
    response = await service(options);
    return response;
  } catch (err) {
    return response;
  }
}
