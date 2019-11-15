import axios from 'axios';

export function get(url, params) {
  return axios({
    url: url,
    method: 'GET',
    ...params,
  });
}

export function post(url, params) {
  return axios({
    url: url,
    method: 'POST',
    ...params,
  });
}
